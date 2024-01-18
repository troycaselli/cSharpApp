using System;

public class ContosoZoo
{

    readonly string[] pettingZoo =
    {
        "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
        "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
        "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
    };

    public void CreateGroups()
    {
        Console.WriteLine();
        PlanSchoolVisit("School A");
        Console.WriteLine();
        PlanSchoolVisit("School B", 3);
        Console.WriteLine();
        PlanSchoolVisit("School C", 2);
    }

    void PlanSchoolVisit(string schoolName, int groups = 6)
    {
        RandomizeAnimals();
        string[,] group = AssignGroup(groups);
        Console.WriteLine(schoolName);
        PrintGroup(group);
    }

    void RandomizeAnimals()
    {
        Random random = new();

        for (int i = 0; i < pettingZoo.Length; i++)
        {
            int r = random.Next(i, pettingZoo.Length);

            (pettingZoo[i], pettingZoo[r]) = (pettingZoo[r], pettingZoo[i]);
        }
    }

    string[,] AssignGroup(int groups = 6)
    {
        int start = 0;
        string[,] result = new string[groups, pettingZoo.Length / groups];

        for (int i = 0; i < groups; i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] = pettingZoo[start++];
            }
        }

        return result;
    }

    static void PrintGroup(string[,] group)
    {
        for (int i = 0; i < group.GetLength(0); i++)
        {
            Console.Write($"Group {i + 1}: ");
            for (int j = 0; j < group.GetLength(1); j++)
            {
                if (j == group.GetLength(1) - 1)
                {
                    Console.Write($"{group[i, j]}");
                }
                else
                {
                    Console.Write($"{group[i, j]}, ");
                }
            }
            Console.WriteLine();
        }
    }


}