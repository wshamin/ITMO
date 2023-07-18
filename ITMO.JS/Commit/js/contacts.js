window.onload = function() {
    document.getElementById("callbackForm").addEventListener("submit", changeContent);
}

class Letter {
    constructor(sender, mail, message) {
        this.sender = sender;
        this.mail = mail;
        this.message = message;
    }
}

messages = [];

document.querySelector('form').addEventListener('submit', function(event) {
    event.preventDefault(); // остановить стандартное поведение формы (перезагрузку страницы)

    var name = document.getElementById('name').value;
    var email = document.getElementById('email').value;
    var message = document.getElementById('message').value;

    console.log('Имя: ' + name);
    console.log('Email: ' + email);
    console.log('Сообщение: ' + message);

    // Теперь вы можете использовать эти данные как вам угодно
    // Например, вы можете отправить их на сервер с помощью AJAX
});

function sendMessage() {
    form = document.getElementById("callbackForm");
    form.eve

    var name = document.getElementById("name").value;
    var email = document.getElementById("email").value;
    var message = document.getElementById("message").value;

    ltr = new Letter(name, email, message); 
    messages.push.ltr;
}