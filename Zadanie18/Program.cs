// Проверить истинность утверждения 
// ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool x1 = false;
bool y1 = false;

if( !(x1|| y1) == (!x1 && !y1) )
    Console.WriteLine("false" );
else
{
     Console.WriteLine("true");
}
bool x2 = false;
bool y2 = true;

if( !(x2|| y2) == (!x2 && !y2) )
    Console.WriteLine("false" );
else
{
     Console.WriteLine("true");
}
bool x3 = true;
bool y3 = false;

if( !(x3|| y3) == (!x3 && !y3) )
    Console.WriteLine("false" );
else
{
     Console.WriteLine("true");
}
bool x4 = true;
bool y4 = true;
if ( !(x4|| y4) == (!x4 && !y4) )
    Console.WriteLine( "true" );
else
{
     Console.WriteLine("false");
}