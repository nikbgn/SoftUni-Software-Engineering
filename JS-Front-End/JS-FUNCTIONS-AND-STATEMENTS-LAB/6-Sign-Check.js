function solve(n1,n2,n3) {
    //Write a function, that checks whether the result of the multiplication numOne * numTwo * numThree is positive or negative. 
    //Try to do this WITHOUT multiplying the 3 numbers
    let nums = [n1,n2,n3];
    let positive = 0;
    let negative = 0;
    nums.forEach((num) => {
        if(num > 0) positive++;
        else negative++;
    })

    if(negative === 3) return 'Negative';
    if(positive === 2) return 'Negative';
    return 'Positive';

}