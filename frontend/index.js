async function test() {

    const response = await fetch('http://localhost:5100/todo', {
        method: "POST", // *GET, POST, PUT, DELETE, etc.
        mode: "cors", // no-cors, *cors, same-origin
        cache: "no-cache", // *default, no-cache, reload, force-cache, only-if-cached
        credentials: "same-origin", // include, *same-origin, omit
        headers: {
            "Content-Type": "application/json",
        },
        redirect: "follow", // manual, *follow, error
        referrerPolicy: "no-referrer", // no-referrer, *no-referrer-when-downgrade, origin, origin-when-cross-origin, same-origin, strict-origin, strict-origin-when-cross-origin, unsafe-url
        body: JSON.stringify({
            taskName: "string",
            isDone: true,
            time: "2023-03-16T18:05:58.998Z"
        })
    }).then(response => {
        console.log(response)
    })
        .catch(error => {
            console.log(error)
        });

    if (response.ok) {
        console.log('Data sent successfully');
    } else {
        console.error('Error sending data');
    }
}
