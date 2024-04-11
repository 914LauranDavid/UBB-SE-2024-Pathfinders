using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.GameOfLife.Cards
{
    public class CustomizableTexture : Texture
    {
        private readonly CustomizableType _type;

        public CustomizableTexture(CustomizableType type, Texture texture)
        {
            this._type = type;
        }

        public CustomizableType GetCustomizableType()
        {
            return _type;
        }
    }
}
