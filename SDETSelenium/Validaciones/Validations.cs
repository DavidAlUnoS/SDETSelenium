using SDETSelenium.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SDETSelenium.Validaciones
{
    public class Validations : LoginActions
    {
        public Validations()
        {
        }

        internal void ValidateElementIsDisplayed(IWebElement element)
        {
            Assert.True(element.Displayed);
        }

    }
}
