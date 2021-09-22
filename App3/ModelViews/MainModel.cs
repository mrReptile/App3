using System;
using System.Collections.Generic;
using System.Text;

namespace App3.ModelViews
{
    class MainModel : BaseModel
    {
        private string nombre;
        private string apellidoP;
        private string apellidoM;
        private string completo;

        public MainModel()
        {
            nombre = "";
            apellidoP = "";
            apellidoM = "";
            completo = "";
        }

        public string Nombre
        {
            get => nombre;

            set
            {
                if (string.Equals(nombre, value)) return;
                nombre = value;
                RaisePropertyChanged(nameof(Nombre));
                RaisePropertyChanged(nameof(Completo));

            }
        }

        public string ApellidoP
        {
            get => apellidoP;

            set
            {
                if (string.Equals(apellidoP, value)) return;
                apellidoP = value;
                RaisePropertyChanged(nameof(ApellidoP));
                RaisePropertyChanged(nameof(Completo));

            }
        }

        public string ApellidoM
        {
            get => apellidoM;

            set
            {
                if (string.Equals(apellidoM, value)) return;
                apellidoM = value;
                RaisePropertyChanged(nameof(ApellidoM));
                RaisePropertyChanged(nameof(Completo));

            }
        }

        public string Completo
        {
            get { return String.Format("Hola: {0} {1} {2}", Nombre, ApellidoP, ApellidoM); }
        }


        

    }
}
