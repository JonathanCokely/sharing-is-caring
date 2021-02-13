import { signalR } from "./signalr/dist/browser/signalr";

let connection = new signalR.HubConnectionBuilder().withURL("/MessageHub").build();
connection.on('sendToUser', (articleHeading, articleContent) => {
    var heading = document.createElement("h3");
    heading.textContent = articleHeading;
    var p = document.createElement("p");
    p.innerText = articleContent;

    var div = document.createElement("div");
    div.appendChild(heading);
    div.appendChild(p);

    document.getElementById("articleList").appendChild(div);
});

connection.start().catch(error =>
    { console.error(error.message) }
);

function sendMessageToHub() {
    connection.invoke('sendMessage', message)
}