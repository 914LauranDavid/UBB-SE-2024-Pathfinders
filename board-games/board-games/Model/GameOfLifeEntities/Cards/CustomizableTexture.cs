using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.GameOfLife.Cards
{
    public class CustomizableTexture
    {
        private readonly CustomizableType _type;
        private readonly Texture _texture;

        public CustomizableTexture(CustomizableType type, Texture texture)
        {
            this._type = type;
            this._texture = texture;
        }

        public CustomizableType GetCustomizableType()
        {
            return _type;
        }

        public Texture GetTexture()
        {
            return _texture;
        }
    }
}
