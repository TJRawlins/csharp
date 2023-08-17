int[] nbrs = { 9, 1, 6, 9, 2, 4, 5, 3, 1, 3 };

int sum = 0;
int sum2 = nbrs[0] + nbrs[1] + nbrs[2] + nbrs[3] + nbrs[4] + nbrs[5]+ nbrs[6]+ nbrs[7] + nbrs[8] + nbrs[9];

int index = 0;
int sum3 = nbrs[index]
            + nbrs[++index]
            + nbrs[++index]
            + nbrs[++index]
            + nbrs[++index]
            + nbrs[++index]
            + nbrs[++index]
            + nbrs[++index]
            + nbrs[++index]
            + nbrs[++index];

for (int i = 0; i < nbrs.Length; i++)
{
    sum += nbrs[i];
}

Console.WriteLine($"The sum of nbrs is {sum}");
Console.WriteLine($"The sum2 of nbrs is {sum2}");
Console.WriteLine($"The sum3 of nbrs is {sum3}");

// Integer divided by decimal will always result in an integer. Must cast or make it an decimal /double
double avg = sum / (nbrs.Length + .0);
Console.WriteLine($"The avg is {avg}");
