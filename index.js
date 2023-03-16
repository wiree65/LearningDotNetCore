async function test() {
    const TaskName = 'test';
    const IsDone = 'True';
    const Time = "2023-03-16T17:06:03.837Z";

    const data = { TaskName, IsDone, Time };

    const response = await fetch('http://localhost:5100/todo', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(data)
    });

    if (response.ok) {
        console.log('Data sent successfully');
    } else {
        console.error('Error sending data');
    }
}
