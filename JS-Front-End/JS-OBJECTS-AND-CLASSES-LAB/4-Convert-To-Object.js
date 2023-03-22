function convert_to_object(text) {
    let object_from_string = JSON.parse(text);
    for (const key of Object.keys(object_from_string)) {
        console.log(`${key}: ${object_from_string[key]}`);
    }
}
