<script lang="ts">
export function beginDrag() {
  return (event:HTMLElement, data: any) => {
    event.classList.add("card")

    data.dataTransfer.effectAllowed = "move"
    data.setData("application/json", data.target.id)
    data.currentTarget
  }
}

export function endDrag() {
  return (data: any) => {
    data.dataTransfer.getData("application/json")

    const element = document.getElementsByClassName(data)
    const tabletop = data.currentTarget

    tabletop.appendChild(element)
  }
}

export function dropOff() {
  ((event: HTMLElement) => {
    event.classList.remove("card")
  })
}

export function handleCard() {
  ((card: EventTarget) => {
    card.addEventListener("ondragstart", beginDrag)
    card.addEventListener("ondragend", endDrag)
    card.addEventListener("ondrop", dropOff)
  })
}
</script>