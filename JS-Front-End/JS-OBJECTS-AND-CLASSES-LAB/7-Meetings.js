function meetings(meetings_info) {
  const meetings = {};
  meetings_info.forEach((meeting_info) => {
    let information = meeting_info.split(' ');

    let day = information[0];
    let person_name = information[1];

    if(day in meetings){
        console.log(`Conflict on ${day}!`);
    }
    else{
        meetings[day] = person_name;
        console.log(`Scheduled for ${day}`);
    }
  });

  for(const key of Object.keys(meetings)){
    console.log(`${key} -> ${meetings[key]}`);
  }
}


meetings(['Monday Peter',
'Wednesday Bill',
'Monday Tim',
'Friday Tim']);