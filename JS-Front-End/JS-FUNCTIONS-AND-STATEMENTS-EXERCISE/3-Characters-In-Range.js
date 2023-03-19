function characters_in_range(start,end) {
    let startChar = start.charCodeAt(0);
    let endChar = end.charCodeAt(0);

    let startFrom = Math.min(startChar,endChar);
    let endAt = Math.max(startChar,endChar);

    let output = []
    for(let i = startFrom + 1; i < endAt; i++){
        output.push(String.fromCharCode(i));
    }

    console.log(output.join(' '));
}