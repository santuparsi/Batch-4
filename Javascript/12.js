function f1() {
    console.log("Hello World");
}
let f=()=>console.log("I am a Arrow function");
f1();
f();
let sum=(a,b)=>{
    return a+b;
}
let res=sum(12,23);
console.log(res);