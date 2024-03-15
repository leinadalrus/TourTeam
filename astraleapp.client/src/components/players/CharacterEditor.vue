<script setup lang="ts"></script>

<template>
  <section :class="styles.CharacterEditorForm">
    <form action="" method="post">
      <label for="">Input Character Name:</label>
      <input type="text" name="company" placeholder="Company?" />

      <label for="division">Company</label>
      <input type="text" name="division" placeholder="Division?" />

      <label for="division">Division</label>
      <input type="text" />

      <label for="specials-select">Select your Specialisation</label>
      <select id="specials-select">
        <optgroup label="Specialisation">
          <option>Gunnery</option>
        </optgroup>
      </select>

      <label for="">Avatar/Profile Picture:</label>
      <input type="image" src="" alt="" name="avatar" />

      <div>
        <input type="submit" value="Submit">
      </div>
    </form>
  </section>
</template>

<style scoped module="styles" lang="scss">
.CharacterEditorForm {
  margin: auto;
  padding: 1rem;
}
</style>