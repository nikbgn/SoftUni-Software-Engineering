function palindrome_integers(arr) {
    arr.forEach(element => {
        let int_to_string = element.toString();
        let reverse = element.toString();
        reverse = Array.from(String(reverse), (n) => Number(n));
        reverse = reverse.reverse();
        reverse = String(reverse).split(',').join("");

        if(int_to_string === reverse) console.log(true);
        else console.log(false);
    });
}
