function lockedProfile() {
  const profiles = Array.from(document.querySelectorAll(".profile"));
  profiles.forEach((profile) => {
    //Add event listener to the profile's button.
    const button = profile.querySelector("button");
    button.addEventListener("click", clickHandler);
  });

  function clickHandler() {
    const button = this;
    const currentProfile = this.parentElement;
    const divWithInfo = currentProfile.querySelector("div");
    const unlock = currentProfile.querySelector('input[value="unlock"]');

    if (unlock.checked) {
      if (button.textContent === "Show more") {
        divWithInfo.style.display = "block";
        button.textContent = "Hide it";
      } else {
        divWithInfo.style.display = "none";
        button.textContent = "Show more";
      }
    }
  }
}
