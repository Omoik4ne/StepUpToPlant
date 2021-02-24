using System;

namespace StepUpToPlants.Models
{
    public class PlantSheet
    {
        private string _type, _comName, _scienName, _maxHeight, _needLight, _description,_plantTime, _harvTime, _favPlant, _avoidPlant;
        private string _bigPicture;

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public string ComName
        {
            get
            {
                return _comName;
            }

            set
            {
                _comName = value;
            }
        }

        public string ScienName
        {
            get
            {
                return _scienName;
            }

            set
            {
                _scienName = value;
            }
        }

        public string NeedLight
        {
            get
            {
                return _needLight;
            }

            set
            {
                _needLight = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public string FavPlant
        {
            get
            {
                return _favPlant;
            }

            set
            {
                _favPlant = value;
            }
        }

        public string AvoidPlant
        {
            get
            {
                return _avoidPlant;
            }

            set
            {
                _avoidPlant = value;
            }
        }

        public string MaxHeight
        {
            get
            {
                return _maxHeight;
            }

            set
            {
                _maxHeight = value;
            }
        }

        public string PlantTime
        {
            get
            {
                return _plantTime;
            }

            set
            {
                _plantTime = value;
            }
        }

        public string HarvTime
        {
            get
            {
                return _harvTime;
            }

            set
            {
                _harvTime = value;
            }
        }

        public string BigPicture
        {
            get
            {
                return _bigPicture;
            }

            set
            {
                _bigPicture = value;
            }
        }
    }
    
}