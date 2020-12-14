function f()
{
    console.log("Hello World..");
}
f();
function Add(a,b)
{
    console.log(a+b);
    f();
}
Add(2,3);
Add("Raghul","Dravid");
function Sum(a,b=10)
{
    return a+b;
}
Sum(12);
super(12,12);