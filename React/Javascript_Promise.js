// Hủy 1 fetch request
const controller = new AbortController();
const {signal} =  controller;
fetch('https:/localhost:8000', {signal}).then(response =>{
    console.log('Request is completed: ');
}).catche(e =>{
    console.warn("fetch with 1 error: ${e.message}");
})
controller.abort();

// waitforTime and Watiforever
function waitforTime(ms)
{
    return new Promise( r=> setTimeout(r, ms));   
}
await waitforTime(200);
function Watiforever(){ return new Promise(r => {});}
await Watiforever();