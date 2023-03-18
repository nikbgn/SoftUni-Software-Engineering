function solve(arr) {
    return [...arr]
        .sort((aName,bName) => aName.localeCompare(bName))
        .map((el,idx) => `${idx+1}.${el}`)
        .join('\n');
}
