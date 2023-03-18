function solve(arr,rotations) {
    while (rotations != 0) {
        let item = arr.shift();
        arr.push(item);
        rotations--;
    }   

    console.log(arr.join(' ',arr));
}