function attachEvents() {
  const BASE_URL = "http://localhost:3030/jsonstore/messenger";
  const authorInput = document.querySelector(
    "#controls > div:nth-child(1) > input:nth-child(2)"
  );
  const messageInput = document.querySelector(
    "#controls > div:nth-child(2) > input:nth-child(2)"
  );
  const sendButton = document.getElementById("submit");
  const refreshButton = document.getElementById("refresh");
  const messagesTextArea = document.getElementById("messages");

  sendButton.addEventListener("click", async () => {
    const message = { author: authorInput.value, content: messageInput.value };
    await fetch(BASE_URL, { method: "POST", body: JSON.stringify(message) });
  });

  refreshButton.addEventListener("click", async () => {
    const messagesResponse = await fetch(BASE_URL);
    const messages = await messagesResponse.json();
    messagesTextArea.textContent = "";
    let messagesToLoad = [];
    for (const message of Object.values(messages)) {
      messagesToLoad.push(`${message["author"]}: ${message["content"]}`);
    }
    messagesTextArea.textContent = messagesToLoad.join('\n');
  });
}

attachEvents();
