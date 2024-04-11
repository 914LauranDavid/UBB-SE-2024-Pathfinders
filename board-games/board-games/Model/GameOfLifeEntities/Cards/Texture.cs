using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.GameOfLife.Cards
{
    /// <summary>
    /// used by CustomizableTexture
    /// </summary>
    public class Texture
    {
        public string BorderHexColor { get; set; }

        public Texture(string borderHexColor)
        {
            BorderHexColor = borderHexColor;
        }
    }
}
