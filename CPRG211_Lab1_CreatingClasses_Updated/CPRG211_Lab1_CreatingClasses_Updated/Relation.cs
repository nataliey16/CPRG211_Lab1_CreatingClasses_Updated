using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Creating_Classes
{
    internal class Relation
    {
        //Constants

        //Fields
        private string relationshipType;
        private Person person1;
        private Person person2;


        //Properties

        public string RelationshipType
        {
            get { return relationshipType; }
        }


        public Person Person1
        {
            get { return person1; }
        }

        public Person Person2
        {
            get { return person2; }
        }


        // Constructors
        public Relation(string relationshipType, Person person1, Person person2)
        {
            this.relationshipType = relationshipType;
            this.person1 = person1;
            this.person2 = person2;

        }


        //Methods

        public string ShowRelationShip()
        {
            string showRelation = Person1.FirstName + " and " + Person2.FirstName + " are " + relationshipType;

            return showRelation;
        }

    }
}
