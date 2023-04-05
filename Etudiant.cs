using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiants
{

    internal class Etudiant
    {
        List<Etudiant> maListe = new List<Etudiant>();

        public int id { get; set; }
        public int Age { get; set; }
        public string Name { get; private set; }

        public Etudiant( int id, int age, string name)
        {
            this.id = id;
            this.Age = age; 
            this.Name = name;
        }


    }
    
    
}
