function calc() {
    // TODO: sum = num1 + num2
    let num1 = Number(document.getElementById('num1').value);
    let num2 = Number(document.getElementById('num2').value);
    let sumBox = document.getElementById('sum');
    sumBox.value = num1+num2;
}