var express = require('express')
var app = express()
var path = require ('path');

app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'ejs');

app.use(express.static(__dirname + '/'));

app.get('/', function (req, res) {
  res.render('./build/index');
  
});

var server = app.listen(process.env.PORT || 8080, ()=> {
  var host = server.address().address
  var port = server.address().port
  console.log('Conectado al puerto 8080')
})