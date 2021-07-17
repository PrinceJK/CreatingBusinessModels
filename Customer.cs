using System;

namespace CreatingBusinessModels
{
    public class Customer
    {
        private string lastName;
        private string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
    }
}
