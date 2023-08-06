using SQLite;

namespace GreenITBlazor.Models
{
    public class ActivityRecord
    {
        [PrimaryKey]
        public int? Year { get; set; }

        private string _yearStr;

        public string YearStr
        {
            get
            {
                return _yearStr;
            }
            set
            {
                _yearStr = value;
                if (Int32.TryParse(_yearStr, out int year))
                {
                    Year = year;
                }
            }
        }

        private double _beef;
        public double BeefEmission { get; private set; }
        public double Beef
        {
            get { return _beef; }
            set
            {
                _beef = value;
                BeefEmission = _beef * 40;
            }
        }

        private double _coffee;
        public double CoffeeEmission { get; private set; }
        public double Coffee
        {
            get { return _coffee; }
            set
            {
                _coffee = value;
                CoffeeEmission = _coffee * 17;
            }
        }

        private double _milk;
        public double MilkEmission { get; private set; }
        public double Milk
        {
            get { return _milk; }
            set
            {
                _milk = value;
                MilkEmission = _milk * 3;
            }
        }

        private double _lamp;
        public double LampEmission { get; private set; }
        public double Lamp
        {
            get { return _lamp; }
            set
            {
                _lamp = value;
                LampEmission = _lamp * 3;
            }
        }

        private double _pork;
        public double PorkEmission { get; private set; }
        public double Pork
        {
            get { return _pork; }
            set
            {
                _pork = value;
                PorkEmission = _pork * 3;
            }
        }

        private double _poultry;
        public double PoultryEmission { get; private set; }
        public double Poultry
        {
            get { return _poultry; }
            set
            {
                _poultry = value;
                PoultryEmission = _poultry * 3;
            }
        }

        private double _oliverOil;
        public double OliverOilEmission { get; private set; }
        public double OliverOil
        {
            get { return _oliverOil; }
            set
            {
                _oliverOil = value;
                OliverOilEmission = _oliverOil * 3;
            }
        }

        private double _cheese;
        public double CheeseEmission { get; private set; }
        public double Cheese
        {
            get { return _cheese; }
            set
            {
                _cheese = value;
                CheeseEmission = _cheese * 3;
            }
        }

        private double _eggs;
        public double EggsEmission { get; private set; }
        public double Eggs
        {
            get { return _eggs; }
            set
            {
                _eggs = value;
                EggsEmission = _eggs * 3;
            }
        }

        private double _rice;
        public double RiceEmission { get; private set; }
        public double Rice
        {
            get { return _rice; }
            set
            {
                _rice = value;
                RiceEmission = _rice * 3;
            }
        }

        private double _chocolate;
        public double ChocolateEmission { get; private set; }
        public double Chocolate
        {
            get { return _chocolate; }
            set
            {
                _chocolate = value;
                ChocolateEmission = _chocolate * 3;
            }
        }
    }
}