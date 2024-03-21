<script setup lang="ts">
function handleSuite() {
  const startDrag = (e: any) => {
    e.dataTransfer.effectAllowed = "move"
    e.dataTransfer.setData("text/html")
  }

  const drop = (e: any) => {
    e.stopPropagation()
    
    if (e) {
      e.dataTransfer.getData("text/html")
    }

    return false
  }

  function endDrag(e: Event) {
    items.forEach(item => {
      item.classList.remove("over")
    })
  }

  function drag(e: Event) {
    e.preventDefault()
    return false
  }

  function cursorEnters(e: Event) {
    items.forEach(item => {
      item.classList.add("over")
    })
  }

  function cursorLeaves(e: Event) {
    items.forEach(item => {
      item.classList.remove("over")
    })
  }

  let items = document.querySelectorAll(".InsetContainer .CardContainer")

  items.forEach(item => {
    item.addEventListener("dragstart", startDrag)
    item.addEventListener("dragover", drag)
    item.addEventListener("dragenter", cursorEnters)
    item.addEventListener("dragleave", cursorLeaves)
    item.addEventListener("dragend", endDrag)
    item.addEventListener("drop", drop)
  })
}

document.addEventListener("DOMContentLoaded", handleSuite)

export {
  handleSuite
}
</script>