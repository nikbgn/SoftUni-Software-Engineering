function sovle(input) {
  class Song {
    constructor(typeList, name, time) {
      this.typeList = typeList;
      this.name = name;
      this.time = time;
    }
  }

  let songs = [];
  let n = input[0];
  let typeListFilter = input[input.length - 1];
  for (let i = 1; i <= n; i++) {
    let song_info = input[i].split("_");
    let typeList, name, time;
    [typeList, name, time] = song_info;
    let new_song = new Song(typeList, name, time);
    songs.push(new_song);
  }

  if (typeListFilter === "all"){
    songs.forEach((song) => console.log(song.name));
  }else{
    songs
    .filter((song) => song.typeList === typeListFilter)
    .forEach((song) => console.log(song.name));
  }
}
