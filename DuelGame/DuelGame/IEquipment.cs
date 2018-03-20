using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    interface IEquipment
    {
        
        int Damage { get; set; }            // урон
        int Aiming { get; set; }            // прицельность
        int Light { get; set; }             // легкость
        int CountUsing { get; set; }        // количество возможных использований
        int Shield { get; set; }            // щит, защита
    }
}
