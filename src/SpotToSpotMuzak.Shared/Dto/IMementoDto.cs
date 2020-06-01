using System;
using System.Collections.Generic;
using System.Text;

namespace SpotToSpotMuzak.Shared.Dto
{
    public interface IMementoDto
    {
        void SaveState();
        void RestoreState();
        void ClearState();
    }
}
