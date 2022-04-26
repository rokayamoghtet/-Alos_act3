import express from "express";
import DelaiLivraisonRouter from "./routes/DelaiLivraison.js";


const app = express();

app.use(express.json());

app.use("/DelaiLivraison", DelaiLivraisonRouter);

const PORT = 3000;
app.listen(PORT, () => {
  console.log(`The server is running on port ${PORT}`);
});