function sayHello() {
  alert("Hello World");
}

const btnSayHello = document.getElementById("btnSayHello");

btnSayHello.addEventListener("click", function (e) {
  sayHello();
});
