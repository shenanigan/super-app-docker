const server = require("express")();
server.listen(3000, async () => { });
server.get("/super-app", async (_, response) => {
    response.json({ "super": "app" });
});