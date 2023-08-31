
var a = 0;
a++;
var b = ++a;
// step into to go through each line in the method itself
// step over to skip the individual lines in the method
a = square(a);
a--;

int square(int n)
{
    // if running through a long loop, SHFT + F11 will step out of the method
    for (int i =0; i < 200; i++)
    {
        n += 1;
    }
    return n * n;
}