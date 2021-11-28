using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{

    class Piece
    {
        public string PieceComposer { get; set; }
        public string PieceKey { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int initialNumberOfPieces = int.Parse(Console.ReadLine());
            Dictionary<string, List<Piece>> piecesDict = new Dictionary<string, List<Piece>>();
            //Fill initial pieces
            for (int i = 0; i < initialNumberOfPieces; i++)
            {
                string[] currPiece = Console.ReadLine().Split("|");
                string pieceName = currPiece[0];
                string pieceComposer = currPiece[1];
                string pieceKey = currPiece[2];

                if (!piecesDict.ContainsKey(pieceName))
                {
                    piecesDict.Add(pieceName, new List<Piece>() { new Piece() { PieceKey = pieceKey, PieceComposer = pieceComposer } });
                }
                else
                {
                    piecesDict[pieceName].Add(new Piece() { PieceKey = pieceKey, PieceComposer = pieceComposer });
                }

            }

            string[] cmd = Console.ReadLine().Split("|");
            while (cmd[0] != "Stop")
            {
                string currCommand = cmd[0];
                switch (currCommand)
                {
                    case "Add":
                        string currPiece = cmd[1];
                        string currComposer = cmd[2];
                        string currKey = cmd[3];
                        if (!piecesDict.ContainsKey(currPiece))
                        {
                            piecesDict.Add(currPiece, new List<Piece>() { new Piece() { PieceComposer = currComposer, PieceKey = currKey } });
                            Console.WriteLine($"{currPiece} by {currComposer} in {currKey} added to the collection!");
                        }
                        else
                        {
                            Console.WriteLine($"{currPiece} is already in the collection!");
                        }

                        break;

                    case "Remove":
                        string pieceToRemove = cmd[1];
                        if (!piecesDict.ContainsKey(pieceToRemove))
                        {
                            Console.WriteLine($"Invalid operation! {pieceToRemove} does not exist in the collection.");
                        }
                        else
                        {
                            piecesDict.Remove(pieceToRemove);
                            Console.WriteLine($"Successfully removed {pieceToRemove}!");
                        }
                        break;

                    case "ChangeKey":
                        string pieceToChange = cmd[1];
                        string newKey = cmd[2];
                        if (!piecesDict.ContainsKey(pieceToChange))
                        {
                            Console.WriteLine($"Invalid operation! {pieceToChange} does not exist in the collection.");
                        }
                        else
                        {
                            piecesDict[pieceToChange].ForEach(x => x.PieceKey = newKey);
                            Console.WriteLine($"Changed the key of {pieceToChange} to {newKey}!");
                        }
                        break;

                    default:
                        break;
                }

                cmd = Console.ReadLine().Split("|");
            }

            foreach (var item in piecesDict.OrderBy(i => i.Key))
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value[0].PieceComposer}, Key: {item.Value[0].PieceKey}");
            }

            //"{Piece} -> Composer: {composer}, Key: {key}"




        }
    }
}
