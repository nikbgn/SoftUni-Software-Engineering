function movies(input) {
  let movies = [];
  let commandParser = {
    addMovie: function (movieName) {
      let movie = { name: movieName };
      movies.push(movie);
    },

    directedBy: function (movieName, directorName) {
      if (movies.find((m) => m.name === movieName)) {
        let movieToUpdate = movies.find((m) => m.name === movieName);
        movieToUpdate.director = directorName;
      } else {
        return;
      }
    },

    onDate: function (movieName, date) {
      if (movies.find((m) => m.name === movieName)) {
        let movieToUpdate = movies.find((m) => m.name === movieName);
        movieToUpdate.date = date;
      } else {
        return;
      }
    },
  };

  input.forEach((command) => {
    let current_command = command.split(" ");
    if (current_command.includes("addMovie")) {
      current_command.shift();
      commandParser.addMovie(current_command.join(" "));
    } else if (current_command.includes("directedBy")) {
      current_command = command.split("directedBy");
      let movieName = current_command[0].trim();
      let movieDirector = current_command[1].trim();
      commandParser.directedBy(movieName, movieDirector);
    } else if (current_command.includes("onDate")) {
      current_command = command.split("onDate");
      let movieName = current_command[0].trim();
      let movieDate = current_command[1].trim();
      commandParser.onDate(movieName, movieDate);
    }
  });

  let hasAllDataVerifier = function(movie){
    if(!movie.hasOwnProperty('name') || !movie.hasOwnProperty('director') || !movie.hasOwnProperty('date')) return false;
    return true;
  }

  movies
  .filter((m) => hasAllDataVerifier(m))
  .forEach((m) => {
    console.log(JSON.stringify(m));
  });
}

