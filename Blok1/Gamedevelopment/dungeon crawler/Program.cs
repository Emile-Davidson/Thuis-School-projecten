﻿using System;

namespace dungeon_crawler
{
    class Program
    {
        public static PlayerManager playerM;


        public static char[,] grid = new char[,] { 
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }, 
                { '#', 'P', ' ', ' ', ' ', '#', ' ', '#', ' ', '#', '#', '#', ' ', 'm', ' ', '#', 'H', '#', '#' },  
                { '#', ' ', '#', '#', ' ', '#', ' ', '#', ' ', ' ', ' ', '#', ' ', '#', ' ', '#', 'H', '#', '#' },
                { '#', ' ', '#', ' ', 'M', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', '#' }, 
                { '#', ' ', '#', ' ', '#', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', '#' }, 
                { '#', ' ', '#', 'H', '#', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', 'M', '#', '#' },  
                { '#', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', '#', ' ', '#', ' ', '#', '#' },  
                { '#', ' ', '#', '#', '#', ' ', '#', '#', ' ', '#', '#', ' ', '#', '#', ' ', '#', ' ', '#', '#' }, 
                { '#', ' ', '#', '#', '#', ' ', '#', '#', 'H', '#', '#', ' ', '#', ' ', ' ', ' ', ' ', '#', '#' }, 
                { '#', 'H', ' ', 'M', ' ', ' ', ' ', ' ', 'M', '#', ' ', ' ', '#', '#', '#', '#', 'M', 'W', '#' },  
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }

                };
        static void Main(string[] args)
        {
            Console.Clear();
            playerM = new PlayerManager();
            LoadMap();
            }
        
        
        public static void LoadMap() {
            for (int y = 0; y < grid.GetLength(0); y++)
            {
                for (int x = 0; x < grid.GetLength(1); x++)
                {
                    Console.Write(Program.grid[y, x]);

                }
                Console.WriteLine();
            }
          }
        }
    }
