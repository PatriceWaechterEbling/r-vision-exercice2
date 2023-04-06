using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice2
{
    internal class Facteur
    {
        private Vehicule vehicule;
        private Punch punch;

        public Facteur(Vehicule vehicule)
        {
            this.vehicule = vehicule ?? throw new ArgumentNullException(nameof(vehicule));
        }

        public Facteur(Punch punch)
        {
            this.punch = punch ?? throw new ArgumentNullException(nameof(punch));
        }


        public Punch GetPunch()
        {
            return this.punch;
        }

        public void SetPunch(Punch value)
        {
            this.punch = value;
        }

    }
}
