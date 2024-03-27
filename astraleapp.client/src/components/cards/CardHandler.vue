<script setup lang="ts">
function beginDrag(event: any, card: any) {
  event.dataTransfer.dropEffect = "move"  
  event.dataTransfer.effectAllowed = "move"
  event.dataTransfer.setData("TradingCardID", card.id)
}

function dropOff(event: any, cards: any) {
  const cardID = event.dataTransfer.getData("TradingCardID")
  const card = cards.find((card: any) => { card.id == cardID })
  card.list = cards
}

export {
  beginDrag,
  dropOff
}
</script>
