// Внести деньги
function addMoney(val) {
    var result = document.getElementsByClassName("balance");
    for (var i = 0; i < result.length; i++) {
        result[i].value = (parseInt(result[i].value) || 0) + parseInt(val);
    }
}

// Покупка продукта. Вычитание из баланса цены продукта
function buyProduct(val) {
    var result = document.getElementById("balance");
    if ((parseInt(result.value) || 0) - parseInt(val) >= 0) {
        result.value = parseInt(result.value || 0) - parseInt(val);
        alert("Спасибо за покупку")
    }
    else {
        alert("Не хватает денег")
    }
}

// Получить сдачу
function getDelivery() {
    var result = document.getElementsByClassName("balance");
    for (var i = 0; i < result.length; i++) {
        result[i].value = 0;
    }
    alert("Спасибо за использование сервиса");
}