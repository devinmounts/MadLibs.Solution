using System;
namespace MadLibs.Models
{
    public class MadLibVariable
    {
        private string _verb;
        private string _name;
        private string _place;

        public string GetVerb()
        {
            return _verb;
        }

        public void SetVerb(string newVerb)
        {
            _verb = newVerb;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string newName)
        {
            _name = newName;
        }

        public string GetPlace()
        {
            return _place;
        }

        public void SetPlace(string newPlace)
        {
            _place = newPlace;
        }
    }
}
