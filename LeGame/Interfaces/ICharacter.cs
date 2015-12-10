﻿using Microsoft.Xna.Framework.Graphics;

namespace LeGame.Interfaces
{
    public interface ICharacter
    {
        Texture2D Texture { get; set; }

        int MaxHealth { get; set; }

        int CurrentHealth { get; set; }

        int Speed { get; set; }
    }
}
