using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGameRH.Models
{
    public class Location
    {
        #region ENUMS


        #endregion

        #region FIELDS

        private int _id; 
        private string _name;
        private string _description;
        private bool _accessible;
        private int _requiredLevel;
        private int _modifiyLevel;
        private int _modifyHealth;
        private string _message;

        #endregion


        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public bool Accessible
        {
            get { return _accessible; }
            set { _accessible = value; }
        }

        public int ModifiyExperiencePoints
        {
            get { return _modifiyLevel; }
            set { _modifiyLevel = value; }
        }

        public int RequiredLevel
        {
            get { return _requiredLevel; }
            set { _requiredLevel = value; }
        }

        public int ModifyHealth
        {
            get { return _modifyHealth; }
            set { _modifyHealth = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        #endregion


        #region CONSTRUCTORS



        #endregion


        #region METHODS

        public bool IsAccessibleByLevel(int playerLevel)
        {
            return playerLevel >= _requiredLevel ? true : false;
        }

        #endregion
    }
}
