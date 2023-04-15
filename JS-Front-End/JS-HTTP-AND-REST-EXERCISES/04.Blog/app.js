function attachEvents() {
  const BASE_URL = "http://localhost:3030/jsonstore/blog/";
  const loadPostsButton = document.getElementById("btnLoadPosts");
  const viewPostsButton = document.getElementById("btnViewPost");
  const postsSelect = document.getElementById("posts");
  const postCommentsUl = document.getElementById("post-comments");
  const postTitle = document.getElementById("post-title");
  const postBody = document.getElementById("post-body");

  loadPostsButton.addEventListener("click", loadPostsHandler);
  viewPostsButton.addEventListener("click", viewCommentsHandler);

  async function loadPostsHandler() {
    postsSelect.innerHTML = "";
    const postsResponse = await fetch(BASE_URL + "posts");
    const posts = await postsResponse.json();

    for (const post of Object.values(posts)) {
      const option = optionBuilder(post.title, post.id);
      postsSelect.appendChild(option);
    }
  }

  async function viewCommentsHandler() {
    postCommentsUl.innerHTML = "";
    const commentsResposne = await fetch(BASE_URL + "comments");
    const comments = await commentsResposne.json();
    const selectedOption = postsSelect.options[postsSelect.selectedIndex].value;
    const selectedPost =
      postsSelect.options[postsSelect.selectedIndex].textContent;

    postTitle.textContent = selectedPost;
    postBody.textContent = await getPostBodyById(selectedOption);

    for (const comment of Object.values(comments)) {
      if (comment.postId === selectedOption) {
        const loadComment = commentBuilder(comment.text);
        postCommentsUl.appendChild(loadComment);
      }
    }
  }

  async function getPostBodyById(id) {
    let textRes = await fetch(BASE_URL + "posts");
    let textContent = await textRes.json();
    return textContent[id].body;
  }

  function optionBuilder(content, value) {
    const newOption = document.createElement("option");
    newOption.textContent = content;
    newOption.value = value;
    return newOption;
  }

  function commentBuilder(commentText) {
    const li = document.createElement("li");
    li.textContent = commentText;
    return li;
  }
}

attachEvents();
