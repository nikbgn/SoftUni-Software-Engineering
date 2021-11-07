using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyMaterials = new Dictionary<string, int>();//Material, Qty
            //Default important items!
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("motes", 0);
            keyMaterials.Add("fragments", 0);
            var junkMaterials = new Dictionary<string, int>();//Junk material, Qty

            while (true)
            {
                //Take materials
                List<string> materials = Console.ReadLine().Split().ToList();
                while (materials.Count > 0)
                {
                    int qtyOfMaterial = int.Parse(materials[0]);
                    string material = materials[1].ToLower();
                    //Check if material is Key Material
                    if (material == "shards" || material == "motes" || material == "fragments")
                    {
                            keyMaterials[material] += qtyOfMaterial;
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, qtyOfMaterial);
                        }
                        else
                        {
                            junkMaterials[material] += qtyOfMaterial;
                        }
                    }


                    if (keyMaterials.ContainsKey("shards"))
                    {
                        if (keyMaterials["shards"] >= 250)
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            keyMaterials["shards"] -= 250;
                            PrintKeyMaterials(keyMaterials, junkMaterials);
                            return;
                        }
                    }

                    if (keyMaterials.ContainsKey("fragments"))
                    {
                        if (keyMaterials["fragments"] >= 250 && keyMaterials.ContainsKey("fragments"))
                        {
                            Console.WriteLine("Valanyr obtained!");
                            keyMaterials["fragments"] -= 250;
                            PrintKeyMaterials(keyMaterials, junkMaterials);
                            return;
                        }

                    }

                    if (keyMaterials.ContainsKey("motes"))
                    {
                        if (keyMaterials["motes"] >= 250 && keyMaterials.ContainsKey("motes"))
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            keyMaterials["motes"] -= 250;
                            PrintKeyMaterials(keyMaterials, junkMaterials);
                            return;
                        }
                    }

                    materials.RemoveAt(0);
                    materials.RemoveAt(0);


                }

            }
            

        }

        private static void PrintKeyMaterials(Dictionary<string, int> keyMaterials, Dictionary<string, int> junkMaterials)
        {

            foreach (var item in keyMaterials.OrderByDescending(qty => qty.Value).ThenBy(name => name.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkMaterials.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
