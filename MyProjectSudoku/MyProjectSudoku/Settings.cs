using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectSudoku
{
    class Settings
    {
        public bool WrongLimit { get; set; }
        public bool IllumCells { get; set; }
        public bool CheckWrong { get; set; }
        public bool HideNumbers { get; set; }
        public bool HighSimNumbers { get; set; }

        private bool _WrongLimit;
        private bool _IllumCells;
        private bool _CheckWrong;
        private bool _HideNumbers;
        private bool _HighSimNumbers;

        public Settings()
        {
            this.WrongLimit = true;
            this.IllumCells = true;
            this.CheckWrong = true;
            this.HideNumbers = true;
            this.HighSimNumbers = true;
        }

        public void CopyToUser()
        {
            _WrongLimit = WrongLimit;
            _IllumCells = IllumCells;
            _CheckWrong = CheckWrong;
            _HideNumbers = HideNumbers;
            _HighSimNumbers = HighSimNumbers;
        }

        public void CopyFromUser()
        {
            WrongLimit = _WrongLimit;
            IllumCells = _IllumCells;
            CheckWrong = _CheckWrong;
            HideNumbers = _HideNumbers;
            HighSimNumbers = _HighSimNumbers;
        }
    }
}
