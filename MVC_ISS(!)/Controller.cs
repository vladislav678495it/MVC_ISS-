using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_ISS___
{
    class Controller
    {

        FormMain view;
        Model_ISS model;

        private string validationError;

        public ISS_Controller()
        {
            view = new FormMain(this);
        }
        public delegate void ValidationErrorHandler(string errors);

        public event ValidationErrorHandler OnError;
        public void Index()
        {
            Application.Run(view);
        }
        public bool Create(string x, string y)
        {
            if (Validate(x, y))
            {
                model = new (x, y);
                return true;
            }

            return false;
        }
        public void Show()
        {
            if (model != null)
            {
                view.ISS_Show(model);
            }
            else
            {
                OnError?.Invoke("Error");
            }
        }
        public bool Validate(string x, string y)
        {
            bool isValid = true;
            validationError = "";
            double xVal, yVal;
            if (!Double.TryParse(x.Replace('.', ','), out xVal) || xVal > 10 || xVal < 520)
            {
                validationError += "Incorrect X value!\n";
                isValid = false;
            }
            if (!Double.TryParse(y.Replace('.', ','), out yVal) || yVal > 10 || yVal < 619)
            {
                validationError += "Incorrect Y value!\n";
                isValid = false;
            }
            if (L1 <= 0 || L2 <= 0)
            { }
            if (validationError != "")
            {
                OnError?.Invoke(validationError);
            }
            return isValid;
        }
    }
}
