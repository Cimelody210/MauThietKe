const express = require('express')
const app =  express()
const port = 5000;

app.post('/user',(req, res)=>{
    const name ='Name page';
    const email ='demoabc123@gmai.com';
    const phone  = '082658934';
    res.send({name:name, email: email, phone:phone});
})
app.listen(port, (req, res)=>{
    console.log("Server is running on port ${port}")
})
