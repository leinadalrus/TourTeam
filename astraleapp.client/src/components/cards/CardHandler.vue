<script lang="ts">
function beginDrag() {
  return (event:HTMLElement, data: any) => {
    event.classList.add("card")

    data.dataTransfer.effectAllowed = "move"
    data.setData("application/json", data.target.id)
    data.currentTarget
  }
}

function endDrag() {
  return (data: any) => {
    data.dataTransfer.getData("application/json")

    const element = document.getElementsByClassName(data)
    const tabletop = data.currentTarget

    tabletop.appendChild(element)
  }
}

function dropOff() {
  ((event: HTMLElement) => {
    event.classList.remove("card")
  })
}

function handleCard() {
  ((card: EventTarget) => {
    card.addEventListener("ondragstart", beginDrag)
    card.addEventListener("ondragend", endDrag)
    card.addEventListener("ondrop", dropOff)
  })
}

export {
  beginDrag,
  endDrag,
  dropOff,
  handleCard
}
</script>