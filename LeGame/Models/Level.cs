﻿using System.Collections.Generic;
using LeGame.Interfaces;
using LeGame.Models.Characters;
using LeGame.Models.Items.Projectiles;
using LeGame.Models.LevelAssets;

namespace LeGame.Models
{
    public class Level : ILevel
    {
        public Level(string path, Character character)
        {
            this.Character = character;
            BackgroundBuilder assetBuilder = new BackgroundBuilder(path);

            this.Assets = assetBuilder.Assets;
            this.Tiles = assetBuilder.Tiles;
            this.Enemies = new List<Character>();
        }

        public List<Projectile> Projectiles { get; private set; } = new List<Projectile>();

        public List<Character> Enemies { get; private set; }

        public Character Character { get; private set; }

        public List<GameObject> Assets { get; private set; }

        public List<NonInteractiveBg> Tiles { get; private set; }
    }
}
