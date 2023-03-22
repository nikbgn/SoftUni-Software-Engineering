function city(city_object) {
    for (const key of Object.keys(city_object)) {
        console.log(`${key} -> ${city_object[key]}`);
    }
}
