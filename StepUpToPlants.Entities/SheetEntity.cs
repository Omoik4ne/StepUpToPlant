using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepUpToPlants.Entities
{
    public class SheetEntity
    {
        private int _idPlant;
        private string _comName;
        private string _scienName;
        private string _picture;
        private int _height;
        private string _type;
        private string _needLight;
        private DateTime? _plantTime;
        private DateTime? _harvTime;
        private string _description;
        private string _favPlant;
        private string _avoidPlant;
        private int _idSpecies;
        private int _idCare;
        private int _idExposure;

        public int IdPlant
        {
            get
            {
                return _idPlant;
            }

            set
            {
                _idPlant = value;
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

        public string Picture
        {
            get
            {
                return _picture;
            }

            set
            {
                _picture = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }

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

        public int IdSpecies
        {
            get
            {
                return _idSpecies;
            }

            set
            {
                _idSpecies = value;
            }
        }

        public int IdCare
        {
            get
            {
                return _idCare;
            }

            set
            {
                _idCare = value;
            }
        }

        public int IdExposure
        {
            get
            {
                return _idExposure;
            }

            set
            {
                _idExposure = value;
            }
        }

        public DateTime? PlantTime
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

        public DateTime? HarvTime
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
    }
}
