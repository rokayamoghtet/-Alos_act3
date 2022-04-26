import express from "express";
import {
  getDelaisLivraison,
  getDelaiLivraison,
  deleteDelaiLivraison,
  addDelaiLivraison,
  updateDelaiLivraison,
} from "../controllers/DelaiLivraison.js";

const router = express.Router();

router.get("/", getDelaisLivraison);
router.get("/:Track", getDelaiLivraison);
router.delete("/:Track", deleteDelaiLivraison);
router.post("/", addDelaiLivraison);
router.patch("/:Track", updateDelaiLivraison);

export default router;
