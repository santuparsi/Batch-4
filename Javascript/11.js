function a()
{
    return 5;
}
function b()
{
    return 10;
}
function sum(a,b)
{
    return a()+b();
}
console.log(sum(a,b));
sum(function(){
    return 10;
},function(){
    return 14;
})
sum(()=>5,()=>10);